using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEstacionamento
{
    public partial class CadastroCarro : Form
    {
        private string NumVagaFromArg;
        private Action<int> UpdateVaga;
        public CadastroCarro(int numVagaArg, Action<int> updateVaga)
        {
            InitializeComponent();
            NumVagaFromArg = numVagaArg.ToString();
            UpdateVaga = updateVaga;
            labelVaga.Text = "Vaga " + numVagaArg.ToString();

            string[] fabricantes = {
                "Fiat",
                "Volkswagen",
                "Chevrolet",
                "Ford",
                "Toyota",
                "Honda",
                "Hyundai",
                "Nissan",
                "Peugeot",
                "Citroën",
                "Renault",
                "Mercedes-Benz",
                "BMW",
                "Audi",
                "Volvo",
                "Kia",
                "Mitsubishi",
                "Jeep",
                "Land Rover",
                "Jaguar",
                "Subaru",
                "Suzuki",
                "Porsche",
                "Mini",
                "Chery",
                "JAC Motors",
                "Lifan",
                "Geely",
                "BYD",
                "Troller",
                "Ram",
                "Lexus",
                "Ferrari",
                "Maserati",
                "Rolls-Royce",
                "Aston Martin",
                "Lamborghini",
                "Bugatti",
                "Tesla",
                "Smart",
                "Dodge",
                "Chrysler",
                "Alfa Romeo",
                "Abarth",
                "Peugeot",
                "Citroën",
                "Infiniti",
                "BYD",
                "Borgward",
                "Foton"
            };
            Array.Sort(fabricantes);
            foreach (var item in fabricantes)
                listFabricante.Items.Add(item);
        }

        private void CadastroCarroBtn_Click(object sender, EventArgs e)
        {
            string Placa = InputPlaca.Text;
            string NumVaga = labelVaga.Text.Split(' ')[1];
            string Fabricante = listFabricante.Text;
            string DataEntrada = inputEntrada.Text;
            string DataSaida = inputSaida.Text;
            string Tempo = txtTempo.Text;
            string Valor = txtValor.Text;

            if (Valor.Length == 0)
            {
                using (var dbContext = new DB())    
                {
                    var newTransacao = new DB.Transacao
                    {
                        Placa = Placa,
                        NumVaga = int.Parse(NumVagaFromArg),
                        Fabricante = Fabricante,
                        DataEntrada = DateTime.Parse(DataEntrada),
                        DataSaida = null,
                        Valor = null
                    };
                    dbContext.Transacoes.Add(newTransacao);
                    dbContext.SaveChanges();
                }
                UpdateVaga(int.Parse(NumVaga));
            }
            else
            {
                using (var dbContext = new DB())
                {
                    var newTransacao = new DB.Transacao
                    {
                        Placa = Placa,
                        NumVaga = int.Parse(NumVaga),
                        Fabricante = Fabricante,
                        DataEntrada = DateTime.ParseExact(DataEntrada, "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                        DataSaida = DateTime.Parse(DataSaida),
                    };
                }
            }
        }

        private void BtnEntrada_Click(object sender, EventArgs e)
        {
            inputEntrada.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void BtnSaida_Click(object sender, EventArgs e)
        {
            inputSaida.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }
    }
}
