using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Noite
{
    public class Endereco
    {
        private string Rua;
        private string Numero;
        private string Bairro;
        private string CEP;
        private string Cidade;
        private string Estado;

        public Endereco(string rua, string numero, string bairro, string cep, string cidade, string estado) {
            Rua = rua;
            Numero = numero;
            Bairro = bairro;
            CEP = cep;
            Cidade = cidade;
            Estado = estado;
        }
        


        public string getRua() { return Rua; }
        public void setRua(string rua) {  Rua = rua; }
        public string getNumero() {  return Numero; }
        public void setNumero(string numero) { Numero = numero; } 
        public string getBairro() {  return Bairro; }
        public void setBairro(string bairro) { Bairro = bairro; }
        public string getCEP() { return CEP; }
        public void setCEP(string cep) {  CEP = cep; }
        public string getCidade() { return Cidade; }
        public void setCidade(string cidade) {  Cidade = cidade; }
        public string getEstado() {  return Estado; }
        public void setEstado(string estado) {  Estado = estado; }
    }
}
//shift+alt