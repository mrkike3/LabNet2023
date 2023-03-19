
(() => {

//Referencias html

const btnIntentar        = document.querySelector('#btnIntentar'),
      lblPuntaje         = document.querySelector('#lblPuntaje'),
      txtNumeroIngresado = document.querySelector('#txtNumeroingresado'),
      lblDinamico        = document.getElementById('dinamico'),
      lblPuntajeMaximo   = document.getElementById('puntajeMaximoId'),
      btnReiniciar       = document.getElementById('Reiniciar'),
      mdlModal           = document.getElementById('modal'),
      mdlModal2          = document.getElementById('modal2'),
      btnCerrar          = document.getElementById('btnCerrar'),
      btnCerrar2         = document.getElementById('btnCerrar2'),
      lblMostrarNroGenerado = document.getElementsByClassName('nroGenerado')
      
      


let puntaje= 20;
let puntajeMaximo = 0;
let nroRandom = Math.floor(Math.random() * 20) + 1;
mdlModal.style.display = "none";
mdlModal2.style.display = "none";
lblPuntaje.textContent = `Puntaje: ${puntaje}` ;




  
btnIntentar.addEventListener('click', ()=>{
    
 
  AdivinarNumero();
    
});

btnReiniciar.addEventListener('click', ()=>{
 Reiniciar();

});

btnCerrar.addEventListener('click', ()=>{

  mdlModal.close();
  mdlModal.style.display = "none";
  mdlModal2.style.display = "none";
   });

btnCerrar2.addEventListener('click', ()=>{

  mdlModal2.close();
  mdlModal.style.display = "none";
  mdlModal2.style.display = "none";
   });



function AdivinarNumero(){
   
   if(!(txtNumeroIngresado.value.trim() === "")){
      
     if(txtNumeroIngresado.value == nroRandom)
    {
        
   
        lblDinamico.innerHTML = 'Ganaste' 
        mdlModal.showModal()
        btnIntentar.disabled = true 
        mdlModal.style.display = "flex"
        lblMostrarNroGenerado[0].innerHTML = `El numero correcto era ${nroRandom}`
        if(puntaje > puntajeMaximo){
            puntajeMaximo = puntaje
            lblPuntajeMaximo.textContent = `Puntaje mas alto: ${puntajeMaximo}`
        }
    }

    if(txtNumeroIngresado.value > nroRandom){
        Intentar();
        lblDinamico.innerHTML = 'Te pasaste numero demasiado  grande <br> segui intentando';
       
    }

    if(txtNumeroIngresado.value < nroRandom){
        Intentar();
        lblDinamico.innerHTML = 'Numero demasiado chico segui intentando';
       
    
    }   
    if(puntaje == 0){
        lblDinamico.innerHTML = 'Perdiste';
        mdlModal2.showModal();
        btnIntentar.disabled = true;
        lblMostrarNroGenerado[1].innerHTML = `El numero correcto era ${nroRandom}`
        mdlModal2.style.display = "flex";
        lblMostrarNroGenerado.innerHTML = 'gg';

    }
} 
else{
    
    lblDinamico.innerHTML = 'No se aceptan espacios vacios ni caracteres especiales'  
  }
}

function Reiniciar(){
    puntaje = 20;
    txtNumeroIngresado.value = '';
    lblPuntaje.textContent   = `Puntaje: ${puntaje}`;
    btnIntentar.disabled     = false;
    nroRandom                = Math.floor(Math.random() * 20) + 1;
    mdlModal.style.display   = "none";
    mdlModal2.style.display  = "none";
    lblDinamico.innerHTML    = '';
}

function Intentar(){
    puntaje--; 
    lblPuntaje.innerHTML = `Puntaje: ${puntaje}`;
}


})();
