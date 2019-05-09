using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace SequencerDemo
{
    class AutoSizeFormClass
    {

        //A struct to record the initial status information of the from and it's components
        public struct comStatus
        {
            public int Left;
            public int Top;
            public int Width;
            public int Height;
        }

        //Create a list to record the status information of all the components 
        public List<comStatus> compList = new List<comStatus>();

        //To record the component sequence number
        int num = 0;

        //To record the initial status of all the components and save to the list
        public void RecordInitialStatus(Control initialForm)
        {
            comStatus from1;
            from1.Left = initialForm.Left; from1.Top = initialForm.Top; from1.Width = initialForm.Width; from1.Height = initialForm.Height;
            //Add the info of the form to the list
            compList.Add(from1);
            AddControl(initialForm);
        }

        private void AddControl(Control mainForm)
        {
            //For each component in the mainForm, call the method recursion  
            foreach (Control subCtrl in mainForm.Controls)
            {  
                //Use the recursion method add all the sub components to the list 
                comStatus comp;
                comp.Left = subCtrl.Left; comp.Top = subCtrl.Top; comp.Width = subCtrl.Width; comp.Height = subCtrl.Height;
                compList.Add(comp);
                //If still have sub ones: 
                if (subCtrl.Controls.Count > 0)
                    AddControl(subCtrl);
            }
        }


        public void controlAutoSize(Control mainForm)
        {
            //The '0' one is the main form
            if (num == 0)
            { 
                comStatus newFrom;

                newFrom.Left = 0; newFrom.Top = 0; newFrom.Width = mainForm.PreferredSize.Width; newFrom.Height = mainForm.PreferredSize.Height;
                compList.Add(newFrom);
                AddControl(mainForm);
            }

            //Caluculate the propprtion of the newForm & originForm
            float wideScale = (float)mainForm.Width / (float)compList[0].Width;
            float highScale = (float)mainForm.Height / (float)compList[0].Height;

            num = 1;
            autoReSize(mainForm, wideScale, highScale);
        }
        private void autoReSize(Control superCtrl, float wideScale, float highScale)
        {
            int Left0, Top0, Width0, Height0;

            foreach (Control subCtrl in superCtrl.Controls)
            { 
                //Get the origin infos of this components from list
                Left0 = compList[num].Left;
                Top0 = compList[num].Top;
                Width0 = compList[num].Width;
                Height0 = compList[num].Height;

                //Change the size
                subCtrl.Left = (int)((Left0) * wideScale);
                subCtrl.Top = (int)((Top0) * highScale);
                subCtrl.Width = (int)(Width0 * wideScale);
                subCtrl.Height = (int)(Height0 * highScale);

                num++;
                
                //If have any sub components
                if (subCtrl.Controls.Count > 0)
                {
                    autoReSize(subCtrl, wideScale, highScale);
                }
                    
                if (superCtrl is DataGridView)
                {
                    DataGridView dgv = superCtrl as DataGridView;
                    Cursor.Current = Cursors.WaitCursor;

                    int widths = 0;
                    for (int i = 0; i < dgv.Columns.Count; i++)
                    {
                        dgv.AutoResizeColumn(i, DataGridViewAutoSizeColumnMode.AllCells);
                        widths += dgv.Columns[i].Width;                        
                    }
                    
                    if (widths >= superCtrl.Size.Width) 
                        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;   
                    else
                        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;   

                    Cursor.Current = Cursors.Default;
                }
                
            }


        }
    }
}
