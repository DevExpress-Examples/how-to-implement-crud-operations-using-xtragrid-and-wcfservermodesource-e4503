﻿// Developer Express Code Central Example:
// How to implement CRUD operations using XtraGrid and WCF Data Services
// 
// This example is similar to the http://www.devexpress.com/scid=E3866 example and
// demonstrates how to implement CRUD operations using XtraGrid and WCF Data
// Services.
// 
// This example works with the standard SQL Northwind database.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E4365

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Example.ServiceReference1;

namespace Example {
    public partial class EditForm : Form {
        public EditForm(Customers customer) {
            InitializeComponent();
            teComN.DataBindings.Add("EditValue", customer, "CompanyName");
            teConN.DataBindings.Add("EditValue", customer, "ContactName");
            teAdd.DataBindings.Add("EditValue", customer, "Address");
            teC.DataBindings.Add("EditValue", customer, "Country");
        }
    }
}
