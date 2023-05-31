function realizarExperimento() {
    var sustancia1 = "A";
    var sustancia2 = "B";
    var resultado = "";
  
    if (
      (sustancia1 === "A" && sustancia2 === "B") ||
      (sustancia1 === "B" && sustancia2 === "A")
    ) {
      resultado = "Reacción exitosa. Se ha formado una nueva sustancia C";
    } else {
      resultado = "No se ha producido ninguna reacción. Inténtalo de nuevo.";
    }
  
    document.getElementById("resultadoExperimento").innerHTML = resultado;
  }
  
  