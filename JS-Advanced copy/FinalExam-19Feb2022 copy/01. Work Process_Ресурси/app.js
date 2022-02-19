function solve() {

    const firstNameInputElement = document.getElementById('fname');
    const lastNameInputElement = document.getElementById('lname');
    const emailInputElement = document.getElementById('email');
    const birthInputElement = document.getElementById('birth');
    const positionInputElement = document.getElementById('position');
    const salaryInputElement = document.getElementById('salary');
    const hireWorkerButton = document.getElementById('add-worker');
    let sum = 0;

    hireWorkerButton.addEventListener('click', (e) => {

        e.preventDefault();
        if (firstNameInputElement.value != '' && lastNameInputElement.value != '' && emailInputElement.value != '' &&
            birthInputElement.value != '' && positionInputElement.value != '' && salaryInputElement.value != '') {

            const tbodyElement = document.getElementById('tbody');
            const trElement = document.createElement('tr');
            const tdFirstNameElement = document.createElement('td');
            tdFirstNameElement.setAttribute('id', 'first-name');
            tdFirstNameElement.textContent = firstNameInputElement.value;
            const tdLastNameElement = document.createElement('td');
            tdLastNameElement.setAttribute('id', 'last-name');
            tdLastNameElement.textContent = lastNameInputElement.value;
            const tdEmailElement = document.createElement('td');
            tdEmailElement.setAttribute('id', 'email-info');
            tdEmailElement.textContent = emailInputElement.value;
            const tdBirthElement = document.createElement('td');
            tdBirthElement.setAttribute('id', 'birth-info');
            tdBirthElement.textContent = birthInputElement.value;
            const tdPositonElement = document.createElement('td');
            tdPositonElement.setAttribute('id', 'position-info');
            tdPositonElement.textContent = positionInputElement.value;
            const tdSalaryElement = document.createElement('td');
            tdSalaryElement.setAttribute('id', 'salary-info');
            tdSalaryElement.textContent = salaryInputElement.value;
            const tdButtonsElement = document.createElement('td');
            const firedButtonElement = document.createElement('button');
            firedButtonElement.classList.add('fired');
            firedButtonElement.textContent = 'Fired';
            const editButtonElement = document.createElement('button');
            editButtonElement.classList.add('edit');
            editButtonElement.textContent = 'Edit';

            sum += Number(salaryInputElement.value);
            let totalSum = document.getElementById('sum');
            totalSum.textContent = sum.toFixed(2);

            tdButtonsElement.appendChild(firedButtonElement);
            tdButtonsElement.appendChild(editButtonElement);
            trElement.appendChild(tdFirstNameElement);
            trElement.appendChild(tdLastNameElement);
            trElement.appendChild(tdEmailElement);
            trElement.appendChild(tdBirthElement);
            trElement.appendChild(tdPositonElement);
            trElement.appendChild(tdSalaryElement);
            trElement.appendChild(tdButtonsElement);
            tbodyElement.appendChild(trElement);

            firstNameInputElement.value = '';
            lastNameInputElement.value = '';
            emailInputElement.value = '';
            birthInputElement.value = '';
            positionInputElement.value = '';
            salaryInputElement.value = '';

            firedButtonElement.addEventListener('click', (e) => {
                let salary = e.currentTarget.parentNode.previousSibling.textContent;
                sum -= Number(salary);
                totalSum.textContent = sum.toFixed(2);
                e.currentTarget.parentNode.parentNode.remove();
            });

            editButtonElement.addEventListener('click', (e) => {

                firstNameInputElement.value = document.getElementById('first-name').textContent;
                lastNameInputElement.value = document.getElementById('last-name').textContent;
                emailInputElement.value = document.getElementById('email-info').textContent;
                birthInputElement.value = document.getElementById('birth-info').textContent;
                positionInputElement.value = document.getElementById('position-info').textContent;
                salaryInputElement.value = document.getElementById('salary-info').textContent;
                let salary = e.currentTarget.parentNode.previousSibling.textContent;
                sum -= Number(salary);
                totalSum.textContent = sum.toFixed(2);
                e.currentTarget.parentNode.parentNode.remove();

            })

        }
    })
}

solve()

//firstNameInputElement.value != '' && lastNameInputElement.value != '' && emailInputElement.value != '' &&
//birthInputElement.value != '' && positionInputElement.value != '' && salaryInputElement.value != ''