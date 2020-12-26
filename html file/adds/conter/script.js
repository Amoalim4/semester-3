

const digit = document.getElementById('digit').innerHTML

const num = parseInt(digit)
let x = parseInt(num)


function addFunction()
{
   x+=1;
   document.getElementById('digit').innerHTML = x;
   if(x > 999)
   {
    document.getElementById('digit').style.width ="auto"
    document.getElementById('digit').style.marginLeft = "-30px"
   }
   
}

function resetFunction()
{
    x=0;
    document.getElementById('digit').innerHTML = 0;
    document.getElementById('digit').style.width ="100px"
}
