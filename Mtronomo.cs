using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Timers;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        /// variables globales
        int bstate = 1;//estado del boton inicio
        SoundPlayer sound = new SoundPlayer(@"C:\Users\SNK93\source\repos\WpfApp1\WpfApp1\bin\Debug\Sonidos\tiempo_fuerte.wav");////se declara el objeto sonido y se asigna path del audio
        Bunifu.Framework.UI.BunifuThinButton2[] cajas = new Bunifu.Framework.UI.BunifuThinButton2[4];//arreglo de thinbutton2 donde se mostraran los clicks
        int indice_caja = 0;//indica que caja se tiene que prender
        int compas;//guarda el compas seleccionado
        int contador_compases = 0;//guarda el numero de compases que se han dado
        int avanzar = 0;//guarda los compases que se vana  avanzar
        int cada = 0;//guarda cada cuantos compases cambiara el tempo
        int bpm = 0;//guarda los puntos de la caja bpm
        /// </summary>
        public Form1()
        {

            InitializeComponent();
            bpm = Int16.Parse(bpm_textbox.Text);//obtiene los puntos de bpm
            

        }
        private void Iniciar_Click(object sender, EventArgs e)//boton de inicio
        {
            bstate = bstate * (-1);
            Acomodar_cajas();


            if (bstate == 1)//detener
            {
                
                iniciar.Text = "Iniciar";
                click_timer.Enabled = false;//detiene el sonido del click
                monitor_timer.Enabled = false;//detiene el encendido de las cajas de los clicks
                td_cb.Enabled = true;//desbloquea checkbox 
                Desbloquear_grupo_compas();
                indice_caja = 0;
                Limpiar_cajas();
                check_box_td_state();
                GC.Collect();//llama al garbage collector
                GC.WaitForPendingFinalizers();

            }
            else//iniciar
            {


                click_timer.Enabled = true;//inicia el sonido de los clicks
                monitor_timer.Enabled = true;//inicia el encendido de las cajas de los clicks
                iniciar.Text = "Detener";
                get_values();//obtiene los valores de las cajas de texto
                bloquear_grupo_td();//bloquea grupo td
                bloquear__grupo_compas();
                GC.Collect();//llama al garbage collector
                GC.WaitForPendingFinalizers();
            }
        }





        void check_box_td_state()//revisa el estado del check box td_para habilitarlo si es necesario
        {
            if (td_cb.Checked == true)
            {
                avanzar_box.Enabled = true;
                cada_box.Enabled = true;
                td_label.Enabled = true;
                compas_button.Enabled = true;
            }

        }
        void bloquear__grupo_compas()
        {
            compas_button.Enabled = false;
            tmp.Enabled = false;
        }

        void Desbloquear_grupo_compas()
        {
            compas_button.Enabled = true;
            tmp.Enabled = true;
        }
        void bloquear_grupo_td()//bloquea los controles del tempo dinamico
        {
            avanzar_box.Enabled = false;
            cada_box.Enabled = false;
            td_cb.Enabled = false;
            td_label.Enabled = false;

        }
        void get_values()
        {
            avanzar = Int16.Parse(avanzar_box.Text);//obtiene los puntos que va a aumentar
            cada = Int16.Parse(cada_box.Text);//obtiene cada que numero de compases va a aumentar
            bpm = Int16.Parse(bpm_textbox.Text);//obtiene los puntos de bpm

        }
        private void set_interval_timers()
        {
            int t = 60000 / bpm;
            click_timer.Interval = t;
            monitor_timer.Interval = t;
        }



        private void Monitor_timer_Tick(object sender, EventArgs e)
        {
            switch (indice_caja)
            {
                case 0:
                    cajas[indice_caja].IdleFillColor = Color.Red;
                    cajas[compas - 1].IdleFillColor = Color.Transparent;

                    break;
                case 1:
                    cajas[indice_caja].IdleFillColor = Color.Red;
                    cajas[0].IdleFillColor = Color.Transparent;
                    break;
                case 2:
                    cajas[indice_caja].IdleFillColor = Color.Red;
                    cajas[1].IdleFillColor = Color.Transparent;
                    break;
                case 3:
                    cajas[indice_caja].IdleFillColor = Color.Red;
                    cajas[2].IdleFillColor = Color.Transparent;
                    break;
            }
            indice_caja++;

            if (indice_caja == compas)//compara si el numerod e click es igual al compas elejido
            {
                indice_caja = 0;
                contador_compases++;//aumenta el compas 
                if (contador_compases == Int16.Parse(cada_box.Text))//compara los compases con la el numero de compases elejido
                {
                    bpm += avanzar;
                    contador_compases = 0;
                    bpm_textbox.Text = bpm.ToString();
                    set_interval_timers();


                }
            }

        }

        private void Click_timer_Tick(object sender, EventArgs e)//metodo para reprudicir el sonido del click
        {
            sound.Play();
            //Console.Beep();
        }



        private void Acomodar_cajas()
        {
            String sele = tmp.selectedValue;//obtiene elvalor del combobox tmp 
            switch (sele)
            {
                case "2/4":
                    compas = 2;
                    break;
                case "3/4":
                    compas = 3;
                    break;
                case "4/4":
                    compas = 4;
                    break;
            }

            int phorizontal = 17; //posicion horizontal de cada rectangulo

            for (int k = 0; k < compas; k++)//imprime todos los rectangulos //acomoda las cajas de los clicks
            {
                cajas[k] = new Bunifu.Framework.UI.BunifuThinButton2();
                cajas[k].ActiveBorderThickness = 1;
                cajas[k].ActiveCornerRadius = 20;
                cajas[k].ActiveFillColor = Color.SeaGreen;
                cajas[k].ActiveForecolor = Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
                cajas[k].ActiveLineColor = Color.SeaGreen;
                cajas[k].Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
                cajas[k].BackColor = Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
                cajas[k].ButtonText = "";
                cajas[k].Cursor = Cursors.Hand;
                paneltransition.SetDecoration(cajas[k], BunifuAnimatorNS.DecorationType.None);
                Logotransition.SetDecoration(cajas[k], BunifuAnimatorNS.DecorationType.None);
                cajas[k].Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                cajas[k].ForeColor = Color.SeaGreen;
                cajas[k].IdleBorderThickness = 1;
                cajas[k].IdleCornerRadius = 20;
                cajas[k].IdleFillColor = Color.Transparent;
                cajas[k].IdleForecolor = Color.White;
                cajas[k].IdleLineColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
                cajas[k].Location = new Point(phorizontal, 4);
                cajas[k].Margin = new Padding(5);

                if (panel3.Height == 173)
                    cajas[k].Size = new Size(80, 163);
                else
                    cajas[k].Size = new Size(80, 78);

                cajas[k].TabIndex = 4;
                cajas[k].TextAlign = ContentAlignment.MiddleCenter;
                separador_monitores.SendToBack();

                separador_monitores.Controls.Add(cajas[k]);//muestra las cajas en el 
                cajas[k].BringToFront();
                phorizontal += 200;//aumenta para acomodar la siguiente caja

            }
        }



        private void mas_Click(object sender, EventArgs e)
        {
            bpm++;
            bpm_textbox.Text = bpm.ToString();
            set_interval_timers();
        }

        private void menos_Click(object sender, EventArgs e)
        {
            bpm--;
            bpm_textbox.Text = bpm.ToString();
            set_interval_timers();
        }

        private void mas_cinco_Click(object sender, EventArgs e)
        {
            bpm += 5;
            bpm_textbox.Text = bpm.ToString();
            set_interval_timers();
        }

        private void menos_cinco_Click(object sender, EventArgs e)
        {
            bpm -= 5;
            bpm_textbox.Text = bpm.ToString();
            set_interval_timers();
        }

        void Limpiar_cajas()
        {

            for (int k = 0; k < compas; k++)
                cajas[k].IdleFillColor = Color.Transparent;

        }
        private void btonmenu_Click_1(object sender, EventArgs e)//boton arrow contrae y expande panel
        {

            btonmenu.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
            if (panel1.Height == 96)//expande
            {
                panel1.Visible = false;
                panel1.Height = 180;
                panel3.Height = 88;
                paneltransition.ShowSync(panel1);
                Logotransition.HideSync(logo);
                Logotransition.ShowSync(logo);




            }
            else
            {
                panel1.Height = 96;
                panel1.Visible = false;
                panel3.Height = 83;
                panel3.Height = 173;
                paneltransition.ShowSync(panel1);
                Logotransition.HideSync(logo);
                Logotransition.ShowSync(logo);
                


            }
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            if (td_cb.Checked == true)
                td_cb.Checked = false;
            else
                td_cb.Checked = true;
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)//boton cerrar
        {
            this.Close();

        }

        private void td_cb_OnChange(object sender, EventArgs e)
        {
            if (td_cb.Checked == true)
            {
                avanzar_box.Enabled = true;
                cada_box.Enabled = true;
            }
            else
            {
                avanzar_box.Text = "0";
                cada_box.Text = "0";
                avanzar_box.Enabled = false;
                cada_box.Enabled = false;
                bloquear_grupo_td();
            }

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            bpm++;
            bpm_textbox.Text = bpm.ToString();
        }

        private void compas_button_Click(object sender, EventArgs e)
        {
            switch (tmp.selectedIndex)
            {

                case 0:
                    tmp.selectedIndex = 1;

                    break;
                case 1:
                    tmp.selectedIndex = 2;

                    break;
                case 2:
                    tmp.selectedIndex = 0;
                    break;

                default : MessageBox.Show("error");
                    break;
            }
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}

