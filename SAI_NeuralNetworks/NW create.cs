using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SAI_NeuralNetworks
{
    using ClassLibraryNeuralNetworks;

    public partial class Form1 : Form
    {

        NumericUpDown[] NLayers; // Настройка нейронов

        Label[] NLayerLabels;// Метка слоя

        int CountLayers = 0;// Кол-во слоев

        int[] Layers;

        int sizeX;

        void CreateNumeric()
        {
            for (int i = 0; i < CountLayers; i++)
            {
                this.groupBox1.Controls.Remove(this.NLayers[i]);
                this.groupBox1.Controls.Remove(this.NLayerLabels[i]);
            }

            CountLayers = (int)numericUpDown3.Value;

            NLayers = new NumericUpDown[CountLayers];
            NLayerLabels = new Label[CountLayers];

            for (int i = 0; i < CountLayers; i++)
            {
                // Создаем счетчик слоев
                NLayers[i] = new NumericUpDown();

                NLayers[i].Left = 6;
                NLayers[i].Top = 71 + 39 * i;

                NLayers[i].Maximum = 10000;
                NLayers[i].Minimum = 1;

                this.groupBox1.Controls.Add(this.NLayers[i]);

                // Создаем Метку i-го скрытого слоя
                NLayerLabels[i] = new Label();
                NLayerLabels[i].Top = 55 + 39 * i;
                NLayerLabels[i].Left = 6;
                NLayerLabels[i].Text = "Нейронов в " + Convert.ToString(i + 1) + " слое: ";
                NLayerLabels[i].AutoSize = true;

                this.groupBox1.Controls.Add(this.NLayerLabels[i]);
            }
            numericUpDown2.Top = 71 + 39 * CountLayers;
            label2.Top = 55 + 39 * CountLayers;
        }

        public Form1()
        {
            InitializeComponent();
        }

        public int[] getLayers
        {
            get
            {
                return Layers;
            }
        }

        public int getSizeX
        {
            get
            {
                return sizeX;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Layers = new int[CountLayers + 1];

            sizeX = (int)numericUpDown1.Value;

            for (int i = 0; i < CountLayers; i++)
                Layers[i] = (int)NLayers[i].Value;

            Layers[CountLayers] = (int)numericUpDown2.Value;

            Close();

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                CreateNumeric();
            }
            catch (System.Exception)
            {
                //"NW Exception";
            }
            finally
            { }
        }
    }
}
