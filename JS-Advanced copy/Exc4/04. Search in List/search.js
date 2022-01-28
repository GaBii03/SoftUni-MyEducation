function search() {
   let elements = Array.from(document.querySelectorAll('ul li'));
   let text = document.getElementById('searchText').value;

   let counter = 0;
   elements.forEach((el) => {

      if(el.innerHTML.includes(text)){
         el.style.fontWeight = 'bold';
         el.style.textDecoration = 'underline';
         counter++;
      }else{
         el.style.fontWeight = 'normal';
         el.style.textDecoration = '';
      }


      document.getElementById('result').textContent = `${counter} matches found`;

   })
}
