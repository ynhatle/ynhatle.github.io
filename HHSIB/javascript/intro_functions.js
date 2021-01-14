  var ns6=document.getElementById&&!document.all

  function primeThePump() {
    if (ns6) {
      setTimeout("removeFlashIntro()", 3500);
    } else {
      setTimeout("removeFlashIntro()", 10000);
    }

  }
  
    function removeFlashIntro() {
    myMovieCell = ns6 ? document.getElementById("myFlashLayer") : document.all.myFlashLayer;
    
    if (myMovieCell) {
      myMovieCell.innerHTML = "";
    }
  }
  window.onload = primeThePump;