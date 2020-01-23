using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CAMADA.DALL.Models;
using CAMADA.DALL.Persistence;

namespace Admin.SysPontus.Pages
{
    public partial class CadastroFuncionarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            if( txtCPF_CNPJ.Text=="" || txtNomeCompleto.Text=="" || txtEmail.Text=="" || txtTelefone.Text=="" || txtEndereço.Text=="" || ddlSexo.Text=="" || txtLogin.Text=="" || txtSenha.Text=="" || txtCargo.Text=="")
            {
                lblMensagem.Text = "Por favor, Preencha todos os campos do formulário...";
                
            }
            else
            {
                Funcionarios f = new Funcionarios();
                f.CPF_CNPJ = txtCPF_CNPJ.Text;
                f.NomeCompleto = txtNomeCompleto.Text;
                f.Email = txtEmail.Text;
                f.Telefone = txtTelefone.Text;
                f.Endereco = txtEndereço.Text;
                f.Sexo = ddlSexo.Text;
                f.Login = txtLogin.Text;
                f.Senha = txtSenha.Text;
                f.Cargo = txtCargo.Text;

                FuncionariosController fc = new FuncionariosController();
                fc.Create(f);

                lblMensagem.Text = "Funcionário " + txtNomeCompleto.Text + ", Foi Cadastrado com sucesso!";

                this.txtCPF_CNPJ.Text = "";
                this.txtNomeCompleto.Text = "";
                this.txtEmail.Text = "";
                this.txtTelefone.Text = "";
                this.txtEndereço.Text = "";
                this.txtLogin.Text = "";
                this.ddlSexo.Text = "0";
                this.txtSenha.Text = "";
                this.txtCargo.Text = "";


            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            this.txtCPF_CNPJ.Text = "";
            this.txtNomeCompleto.Text = "";
            this.txtEmail.Text = "";
            this.txtTelefone.Text = "";
            this.txtEndereço.Text = "";
            this.txtLogin.Text = "";
            this.ddlSexo.Text = "0";
            this.txtSenha.Text = "";
            this.txtCargo.Text = "";
        }
    }
}