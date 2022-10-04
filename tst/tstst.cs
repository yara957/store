using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StorSystem.tst
{
    public partial class tstst : StorSystem.Core.ClscScurUserInterface
    {
        public tstst()
        {
            InitializeComponent();
        }
        protected override bool InitData()
        {

             this.FildsToShow = new List<Control>();
            this.FildsToShow.AddRange(new List<Control>() {  });
            this.buttons.AddRange(new List<Button>() { BtnNew, BtnSave, BtnSearch, BtnDelete });
            if (this.db != null)
            {
            }
            return base.InitData();
        }



    }
}
