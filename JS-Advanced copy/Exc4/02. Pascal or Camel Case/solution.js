function solve() {
  let textElement = document.getElementById('text').value;
  let conventionType = document.getElementById('naming-convention').value;
  let resultElement = document.getElementById('result');

  let textSplited = textElement.split(' ');
  let result = '';

  if (conventionType == 'Pascal Case') {

    for (let index = 0; index < textSplited.length; index++) {
      result += textSplited[index][0].toUpperCase();
      for (let f = 1; f < textSplited[index].length; f++) {
        result += textSplited[index][f].toLowerCase();
      }
    }

  } else if (conventionType == 'Camel Case') {
    for (let index = 0; index < textSplited.length; index++) {
      if (index == 0) {
        result+= textSplited[index].toLowerCase();
      } else {
        result+=textSplited[index][0].toUpperCase();
        for (let f = 1; f < textSplited[index].length; f++) {
          result+=textSplited[index][f].toLowerCase();
        }
      }
    }
  } else {
    result+= 'Error!'
  }

  resultElement.textContent = result;

}