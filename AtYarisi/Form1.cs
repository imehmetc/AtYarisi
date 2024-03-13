using WMPLib;

namespace AtYarisi
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        int kosus = 0;
        public Form1() // ilk calisacak methot constructor
        {
            InitializeComponent();
            player.settings.volume = 5;
            pbAt1.Left = pbAt2.Left = pbAt3.Left = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            kosus++;

            pbAt1.Left += rnd.Next(1,10);
            pbAt2.Left += rnd.Next(1,10);
            pbAt3.Left += rnd.Next(1,10);

            #region Ondeki At'ın belirlenmesi
            PictureBox ondekiAt = pbAt1;
            
            lblFark.Text = Math.Abs(pbBitis.Left - pbAt1.Right).ToString();

            if (pbAt2.Left > ondekiAt.Left)
            {
                ondekiAt = pbAt2;
                
                lblFark.Text = Math.Abs(pbBitis.Left - pbAt2.Right).ToString();
            }

            if (pbAt3.Left > ondekiAt.Left)
            {
                ondekiAt = pbAt3;
                
                lblFark.Text = Math.Abs(pbBitis.Left - pbAt3.Right).ToString();
            }
            
            if (kosus > 10)
            {
                lblOndekiAt.Text = ondekiAt.Tag + " No'lu At Önde Götürüyor..";
            }
            #endregion


            #region Kazanan At
            if (ondekiAt.Right > pbBitis.Left)
            {
                timer1.Stop();
                player.URL = "Sesler/zil.mp3";
                lblSpiker.Text = ondekiAt.Tag + " No'lu At Kazandı!..";
                #endregion

                DialogResult dr = MessageBox.Show("Tekrar oynamak ister misiniz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                
                if (dr == DialogResult.Yes)
                {
                    kosus = pbAt1.Left = pbAt2.Left = pbAt3.Left = 0;
                    btnBaslat.Show();
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            btnBaslat.Hide();
            timer1.Start();
            player.URL = "Sesler/tufek.mp3";
            lblSpiker.Text = "Ve yarış başladı...";
        }
    }
}
