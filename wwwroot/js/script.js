function addHoursToDate(objDate, intHours) {
    var numberOfMlSeconds = objDate.getTime();
    var addMlSeconds = (intHours * 60) * 60001;
    var newDateObj = new Date(numberOfMlSeconds + addMlSeconds);
    return newDateObj;
  }
  
  const $hours = document.getElementById('hours'),
  $minutes = document.getElementById('minutes'),
  $seconds = document.getElementById('seconds'),
  $finalMessage = document.querySelector('.final-sms');
  
  const countdownDate = asignarValor();
  
  function borrarValores(){
      localStorage.removeItem('countdownDate');
  }
  
  
  function asignarValor(){
    valor = localStorage.getItem('countdownDate');
    if (valor) {
      // Si hay un tiempo de inicio guardado, utilizarlo para continuar la cuenta regresiva
      valor = new Date(parseInt(valor, 10)); // Sumar una hora al tiempo de inicio guardado
    } else {
      // Si no hay un tiempo de inicio guardado, establecer el tiempo de inicio actual y guardarlo en el almacenamiento local
      valor = addHoursToDate(new Date(), 1);
      localStorage.setItem('countdownDate', valor.getTime().toString());
    }
    return valor;
  }
  
  document.getElementById('startButton').addEventListener('click', function() {
    let interval = setInterval(function(){
      //Obtener fecha actual y milisegundos
      const now = new Date().getTime();
  
      //Obtener las distancias entre ambas fechas
      let distance = countdownDate - now;
  
      //Calculos a dias-horas-minutos-segundos
      let hours = Math.floor((distance % (1000 * 60 * 60 * 24 )) / (1000 * 60 * 60));
      let minutes = Math.floor((distance % (1000 * 60 * 60)) / (1000 * 60));
      let seconds = Math.floor((distance % (1000 * 60 )) / (1000));
  
      //Escribimos resultados
      $hours.innerHTML = hours;
      $minutes.innerHTML = minutes;
      $seconds.innerHTML = ('0' + seconds).slice(-2);
  
      //Cuando llegue a 0
      if(distance < 0){
          clearInterval(interval);
          $finalMessage.style.transform = 'translateY(0)';
      }
  }, 1000);
  });
  