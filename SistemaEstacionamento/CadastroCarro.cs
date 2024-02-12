using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Drawing.Text;
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
        readonly DB.Transacao VagaInfo = SharedData.ActiveVaga;
        private Action UpdateVaga;
        public CadastroCarro(Action updateVaga)
        {
            InitializeComponent();
            
            UpdateVaga = updateVaga;
            labelVaga.Text = "Vaga " + VagaInfo.NumVaga.ToString();

            if (VagaInfo.Placa != null)
            {
                labelVaga.Text = "Vaga " + VagaInfo.NumVaga.ToString();
                InputPlaca.Text = VagaInfo.Placa;
                listFabricante.Text = VagaInfo.Fabricante;
                inputEntrada.Text = VagaInfo.DataEntrada.ToString();
            }
            else
            {
                labelVaga.Text = "Vaga " + VagaInfo.NumVaga;
            }


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

        private void BtnEntrada_Click(object sender, EventArgs e)
        {
            inputEntrada.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void BtnSaida_Click(object sender, EventArgs e)
        {
            inputSaida.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void CalcularBtn_Click(object sender, EventArgs e)
        {
            if (DateTime.TryParse(inputEntrada.Text, out _) && DateTime.TryParse(inputSaida.Text, out _))
            {
                double Price;
                double TimeDiffHours = (DateTime.Parse(inputSaida.Text) - DateTime.Parse(inputEntrada.Text)).TotalMinutes / 60;
                if (TimeDiffHours < 1)
                    Price = 10;
                else
                    Price = Double.Parse(SharedData.ValorHora) * TimeDiffHours;
                txtTempo.Text = TimeDiffHours.ToString("F2") + "h";
                txtValor.Text = "R$" + Price.ToString("F2");
            }
        }

        private void FinalizarBtn_Click(object sender, EventArgs e)
        {
            string Placa = InputPlaca.Text;
            string NumVaga = labelVaga.Text.Split(' ')[1];
            string Fabricante = listFabricante.Text;
            string DataEntrada = inputEntrada.Text;
            string DataSaida = inputSaida.Text;
            string Tempo = txtTempo.Text.Length > 0 ? txtTempo.Text.Split('h')[0] : "";
            string Valor = txtValor.Text.Length > 0 ? txtValor.Text.Split('$')[1] : "";

            // Save enter to DB
            if (Valor.Length == 0)
            {
                using (var dbContext = new DB())
                {
                    DB.Transacao DataAlreadyExist = (
                        from item in dbContext.Transacoes
                        orderby item.DataEntrada descending
                        where item.Placa == Placa && item.Valor == null
                        select item
                    ).FirstOrDefault();

                    if (DataAlreadyExist == null)
                    {
                        var newTransacao = new DB.Transacao
                        {
                            Placa = Placa,
                            NumVaga = int.Parse(NumVaga),
                            Fabricante = Fabricante,
                            DataEntrada = DateTime.Parse(DataEntrada),
                            DataSaida = null,
                            Valor = null
                        };
                        dbContext.Transacoes.Add(newTransacao);
                        dbContext.SaveChanges();
                    }
                }
            }
            // Save exit to DB
            else
            {
                using (var dbContext = new DB())
                {
                    DB.Transacao existingTransacao = (
                        from item in dbContext.Transacoes
                        orderby item.DataEntrada descending
                        where item.NumVaga == VagaInfo.NumVaga && item.Valor == null
                        select item
                    ).FirstOrDefault();

                    if (existingTransacao != null)
                    {
                        existingTransacao.Placa = Placa;
                        existingTransacao.NumVaga = int.Parse(NumVaga);
                        existingTransacao.Fabricante = Fabricante;
                        existingTransacao.DataEntrada = DateTime.Parse(DataEntrada);
                        existingTransacao.DataSaida = DateTime.Parse(DataSaida);
                        existingTransacao.Valor = Double.Parse(Valor);
                        dbContext.SaveChanges();
                    }
                }
            }
            UpdateVaga();
        }
    }
}
