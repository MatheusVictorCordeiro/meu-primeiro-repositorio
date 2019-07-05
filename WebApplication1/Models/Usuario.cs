using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Remoting.Activation;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Models
{
    public class Usuario
        
    {

       [Required(ErrorMessage ="O Nome é campo obrigatório")]
       
        public String Nome { get; set; }


        [Display(Name = "Observações")]
        [StringLength(50,MinimumLength =5, ErrorMessage ="Insira uma observação de 5 a 50 caracteres")]      
        public String Observacoes { get; set; }



        [Range(18,70,ErrorMessage ="A Idade tem que estar entre 18 a 70 anos")]
        public int Idade { get; set; }
        

        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage="Digite um email valido")]
        public String Email { get; set; }

        [RegularExpression(@"[a-z A-Z]{5,20}", ErrorMessage ="Somente letras e de 5 a 20 caracteres")]
        [Required(ErrorMessage ="O Login é obrigatório")]
        [Remote("LoginUnico","Usuario",ErrorMessage = "Esse Login ja existe")]
        public String Login { get; set; }


        [Required(ErrorMessage = "a senha é obrigatória")]
        public String Senha { get; set; }


        [System.ComponentModel.DataAnnotations.Compare("Senha",ErrorMessage ="As senhas não são iguais")]
        public String ConfirmarSenha { get; set; }



    }
}