using System;
using System.Data;
using System.Windows.Forms;
using LibraryDBMS.Libs;

namespace LibraryDBMS.Forms
{
    public partial class DialogUserAccount : Form
    {
        private readonly DataTable user;

        public DialogUserAccount(DataTable _user)
        {
            InitializeComponent();
            Utils.SetFormIcon(this);
            user = _user;
            InitializeValues();
        }

        private void InitializeValues()
        {
            SuspendLayout();
            Utils.DragFormWithControlMouseDown(this, lblHeader);
            Utils.FixControlFlickering(this);
            PopulateFields();
            ResumeLayout();
        }

        private void PopulateFields()
        {
            DateTime registrationDateTime = Convert.ToDateTime(user.Rows[0]["dateAdded"].ToString());
            DateTime dobDateTime = Convert.ToDateTime(user.Rows[0]["dob"].ToString());

            lblUsername.Text = user.Rows[0]["username"].ToString();
            lblRole.Text = user.Rows[0]["roleName"].ToString();
            lblRegistrationDate.Text = registrationDateTime.ToLongDateString();
            lblName.Text = $"{user.Rows[0]["firstName"]} {user.Rows[0]["lastName"]}";
            lblGender.Text = LibModule.GetGender(user.Rows[0]["gender"].ToString());
            lblDOB.Text = dobDateTime.ToLongDateString();
            lblAddress.Text = user.Rows[0]["addr"].ToString();
            lblTel.Text = user.Rows[0]["tel"].ToString();
            lblEmail.Text = user.Rows[0]["email"].ToString();
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
