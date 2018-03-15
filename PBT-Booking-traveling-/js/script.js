window.onload=function(){
/*    var note = document.getElementById('notebad');
    var width = 500;
    var left=400;
    var setminus , setplus ,setwrite,setpause ;
    var enter =setInterval(minus,1);
    
    function minus(){
        note.innerHTML='';
        note.style.left=left++ ;
          note.style.width=(width--  )+ 'px';
            note.style.width=(width--  )+ 'px';
        if(width<0)
        {
            clearInterval(enter);
        
            clearInterval(setminus);
            setplus = setInterval(plus,1);
        }
    }
    function plus(){
          note.style.left=left-- ;
          note.style.width=(width++  )+ 'px';
            note.style.width=(width++  )+ 'px';
                    
        if(width>500){
          clearInterval(setplus);
              
            setwrite=setInterval(write,1);
                 
        }
    }
    var i = 0;
    var string=['  &nbsp  welcome to our lines' ,'&nbsp  chosse your  pursuit', ' we support all of these ' , '&nbsp &nbsp &nbsp happy traveling'  ];
    function write(){
        note.innerHTML='<span class="write"><b>'  + string[i%4] + '</b></span>';
        i++;
        clearInterval(setwrite);
         setpause =setInterval(pause,2000);
        
    }
    function pause(){
        clearInterval(setpause)
        setminus = setInterval(minus,1);
    }
    
    // Booking ----------
    /*
            var shape = document.getElementById('shape');
            var shape2=document.getElementById('shape2');
            var TD=document.getElementById('TD');
            var DT=document.getElementById('DT');
            var x=0 , y=0 , a=0 , b=0 , z=1100;
            var screenWidth = $('#container').width();
            var width1=1;
            var width2= 1;
            var max = Math.ceil(( screenWidth/8)*7)-65;
            var set = setInterval(move  , 1);
            var set2;
            var d=max;
            var one  ,two;
            shape.style.height='10px';
            shape2.style.height='10px';
        function move(){
            shape.style.width=width1++ +'px';
            shape2.style.width=width2++ +'px';
            
            shape.style.width=width1++ +'px';
            shape2.style.width=width2++ +'px';
            
            shape.style.width=width1++ +'px';
            shape2.style.width=width2++ +'px';
                    if(width1 > max){
                        clearInterval(set);
                        TD.style.left=--max;
                        TD.style.width='10px';
                        DT.style.width='10px';
                        DT.style.left=screenWidth-max-1;
                         set2=setInterval(jump,1);
                    }
        }
  
    function jump(){
        TD.style.height=x++ +'px';
          TD.style.height=x++ +'px';
        shape.style.left=y++;
        shape.style.width=max-- + 'px';
        DT.style.top=z--;
          DT.style.top=z--;
        DT.style.height=a++ +'px';
          DT.style.height=a++ +'px';
        shape2.style.right=b++;
        shape2.style.width=d-- + 'px';
        
        if(a==450){
            for(var i=0 ; i<11 ; i++){
                TD.style.height=x++ +'px';
                  shape.style.left=y++;
        shape.style.width=max-- + 'px';
            }
                DT.style.top=z--;
                DT.style.height=a++ +'px';
            clearInterval(set2);
            radius();
        }
    }
    function radius(){
        shape.style.borderRadius='50px 0px 0px 0px';
        shape2.style.borderRadius='0px 0px 50px 50px';
        DT.style.borderRadius='50px 0px 0px 0px';
        TD.style.borderRadius='0px 50px 50px 0px';
        
        cover();
    }
    function cover(){
                 one = document.getElementById('topLeft');
            
                two = document.getElementById('bottomLeft');
                one.style.background='black';
                one.style.width='5px';
            one.style.height="5px";
            one.style.top=660;
            one.style.left=242;
            one.style.background='rgba(0,0,0,.7)'
        $(one).animate({
        height: '440',
        width: max-5
    });
                
            
         
    }
    */
    
    /*Booking*/ 
 
    
    
}