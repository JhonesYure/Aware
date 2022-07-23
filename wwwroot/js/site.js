// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function validar(form)
{
  var camposenha= document.getElementById('txtsenha');
  var valorsenha = txtsenha.value;

  if(valorsenha.length < 6)//**SENHA */
    {
        caixasenha.innerHTML = "Sua senha precisa ter ao menos 6 caractéres";
        caixasenha.style.display = 'block'
        camposenha.focus();

        return false;
    }
    else
    {
        return true;
    }  
} 