namespace DEA_Program.Console
{
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public static class Navigation
    {
        public static async void NavigateTo(Form currentForm, Form nextForm)
        {
            nextForm.Show();
            await Task.Delay(10);
            currentForm.Hide();
        }


        public static async void GoBackTo(Form currentForm, Form previousForm)
        {
            previousForm.Show();
            await Task.Delay(10);
            currentForm.Hide();
        }
    }
}
