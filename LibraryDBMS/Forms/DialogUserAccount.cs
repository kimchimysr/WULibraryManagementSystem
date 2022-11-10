using System.Data;
using System.Windows.Forms;
using LibraryDBMS.Libs;

namespace LibraryDBMS.Forms
{
    public partial class DialogUserAccount : Form
    {
        private readonly DataTable user;

        public DialogUserAccount()
        {
            InitializeComponent();
            Utils.DragFormWithControlMouseDown(this, lblHeader);
            Utils.FixControlFlickering(this);
        }
        public DialogUserAccount(DataTable _user)
        {
            InitializeComponent();
            user = _user;
            InitializeValues();
        }

        private void InitializeValues()
        {
            SuspendLayout();
            Utils.DragFormWithControlMouseDown(this, lblHeader);
            PopulateFields();
            ResumeLayout();
        }

        private void PopulateFields()
        {

            lblUsername.Text = user.Rows[0]["username"].ToString();
            lblRole.Text = user.Rows[0]["roleName"].ToString();
            lblRegistrationDate.Text = user.Rows[0]["dateAdded"].ToString();
            lblName.Text = $"{user.Rows[0]["firstName"]} {user.Rows[0]["lastName"]}";
            lblGender.Text = user.Rows[0]["gender"].ToString().Equals("M") ? "Male" : "Female";
            lblDOB.Text = user.Rows[0]["dob"].ToString();
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
