function solve() {
   document.querySelector('#searchBtn').addEventListener('click', onClick);

   function onClick() {
      
      let elements = Array.from(document.querySelectorAll('tbody tr'));
      let inputText = document.getElementById('searchField').value.toLowerCase();
      
      elements.forEach((el) => {
         let text = el.textContent.toLowerCase();
         if(text.includes(inputText)){
            el.classList.add('select');
         }else{
            el.classList.remove('select');
         }
      })
      document.getElementById('searchField').value = '';
   }
}