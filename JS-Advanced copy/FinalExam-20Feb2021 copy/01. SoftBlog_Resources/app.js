
function solve(){
   
   const creatorInputElement = document.getElementById('creator');
   const titleInputElement = document.getElementById('title');
   const categoryInputElement = document.getElementById('category');
   const contentInputElement = document.getElementById('content');
   const createButtonElement = document.getElementsByClassName('btn create')[0];
   const postsH2Element = document.querySelector('h2');

   createButtonElement.addEventListener('click', (e) => {
      e.preventDefault();
      const articleElement = document.createElement('article');
      const titleH1Element = document.createElement('h1');
      titleH1Element.textContent = titleInputElement.value;
      const categoryPElement = document.createElement('p');
      categoryPElement.textContent = 'Category:';
      const categoryStrongElement = document.createElement('strong');
      categoryStrongElement.textContent = categoryInputElement.value;
      categoryPElement.appendChild(categoryStrongElement);
      const creatorPElement = document.createElement('p');
      creatorPElement.textContent = 'Creator:';
      const creatorStrongElement = document.createElement('strong');
      creatorStrongElement.textContent = creatorInputElement.value;
      creatorPElement.appendChild(creatorStrongElement);
      const contentPElement = document.createElement('p');
      contentPElement.textContent = contentInputElement.value;
      const divButtonsElements = document.createElement('div');
      divButtonsElements.classList.add('buttons');
      const buttonDeleteElement = document.createElement('button');
      buttonDeleteElement.classList.add('btn');
      buttonDeleteElement.classList.add('delete');
      buttonDeleteElement.textContent = 'Delete';
      const buttonArchiveElement = document.createElement('button');
      buttonArchiveElement.classList.add('btn');
      buttonArchiveElement.classList.add('archive');
      buttonArchiveElement.textContent = 'Archive';
      divButtonsElements.appendChild(buttonDeleteElement);
      divButtonsElements.appendChild(buttonArchiveElement);

      articleElement.appendChild(titleH1Element);
      articleElement.appendChild(categoryPElement);
      articleElement.appendChild(creatorPElement);
      articleElement.appendChild(contentPElement);
      articleElement.appendChild(divButtonsElements);
      postsH2Element.parentElement.appendChild(articleElement);

      buttonArchiveElement.addEventListener('click', (e) => {

         // const liElement = document.createElement('li');
         // liElement.textContent = titleH1Element.textContent;
         // const olElement = document.querySelector('.archive-section ol');
         // olElement.appendChild(liElement);
         // articleElement.remove();

         let articleToArchive = e.target.parentElement.parentElement;
         let archiveOl = document.querySelector('.archive-section ol');
         let archiveLis = Array.from(archiveOl.querySelectorAll('li'));
         let articleTitleHeading = articleToArchive.querySelector('h1');
         let articleTitle = articleTitleHeading.textContent;
         let newTitleLi = document.createElement('li');
         newTitleLi.textContent = articleTitle;
         articleToArchive.remove();
         archiveLis.push(newTitleLi);
         archiveLis.sort((a,b) => a.textContent.localeCompare(b.textContent))
         .forEach(li => archiveOl.appendChild(li));
      });
      
      buttonDeleteElement.addEventListener('click', (e) => {
         e.currentTarget.parentElement.parentElement.remove();
      });

   })

  }
