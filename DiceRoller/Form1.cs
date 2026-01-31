namespace DiceRoller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Die d = new(6);
            d.Roll();
            MessageBox.Show(d.FaceUpValue.ToString());

            MessageBox.Show(d.Roll().ToString());
			InitializeComponent();
        }
    }
}
