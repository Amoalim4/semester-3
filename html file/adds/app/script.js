

var pos = 0, test, test_status, question, choice, choices, chA, chB, chC, correct = 0;

var questions = [
    [ "What is 10 + 4?", "12", "14", "16", "B" ],
	[ "What is 20 - 9?", "7", "13", "11", "A" ],
	[ "What is 7 x 3?", "21", "24", "25", "A" ],
    [ "What is 8 / 2?", "10", "2", "4", "C" ]
    
   
];


// function runQuiz(){

    //
//.style.backgroundColor = "#088d6c";
// time = document.querySelector('#time_left span').style.backgroundColor = "#088d6c";

time= document.querySelector('#time_left .min');

sec =document.querySelector('#time_left .sec');

time_left = 9;
sec_left = 10;

function timeCount()
{
   setInterval(function()
   {
       if(time_left <= 0){
           clearInterval(time_left=0)
       }

       time.innerHTML = time_left
       sec.innerHTML = sec_left
       
       sec_left-=1
       if(sec_left < 1){
       time_left -=1
       sec_left = 59
       }
   },1000)
   
}

function stopTime(){
    time.innerHTML = 00
    sec.innerHTML = 00
}

//



function _(x){
    return document.getElementById(x);
    
}
timeCount()
function renderQuestion(){
    
    test = _("test");
    
	if(pos >= questions.length){
        
		test.innerHTML = "<h2>You got "+correct+" of "+questions.length+" questions correct</h2>";
		_("test_status").innerHTML = "Test Completed";
		pos = 0;
		correct = 0;
		return false;
	}
	_("test_status").innerHTML = "Question "+(pos+1)+" of "+questions.length;
	question = questions[pos][0];
	chA = questions[pos][1];
	chB = questions[pos][2];
	chC = questions[pos][3];
	test.innerHTML = "<h3>"+question+"</h3>";
	test.innerHTML += "<input type='radio' name='choices' value='A'> "+chA+"<br>";
	test.innerHTML += "<input type='radio' name='choices' value='B'> "+chB+"<br>";
	test.innerHTML += "<input type='radio' name='choices' value='C'> "+chC+"<br><br>";
    test.innerHTML += "<button onclick='checkAnswer()'>Next question</button>";
    
}

function checkAnswer(){
 
	choices = document.getElementsByName("choices");
	for(var i=0; i<choices.length; i++){
		if(choices[i].checked){
            choice = choices[i].value;
            
		}
	}
	if(choice == questions[pos][4]){
		correct++;
	}
	pos++;
	renderQuestion();
}
window.addEventListener("load", renderQuestion, false);
// }