window.onload = function(){
    var ancoras = document.getElementsByTagName('img');
    for(var i = 0, ln = ancoras.length; i < ln; i++) new adicionaStatus(ancoras.item(i));
}

function adicionaStatus(elemento){
    elemento.onmouseover = function(){
        window.status = (this.title != null)? this.title : this.src;
    }
}