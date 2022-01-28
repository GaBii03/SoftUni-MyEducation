function solve(person) {

    if (person['dizziness'] == true) {
        let waterToDrink = 0.1 * person['weight'] * person['experience'];
        if (person['levelOfHydrated'] == 0) {
            person['levelOfHydrated'] = waterToDrink;
        } else {
            person['levelOfHydrated'] += waterToDrink;
        }

        person['dizziness'] = false;
    }

     return person;
    //console.log(person);
}

solve({
    weight: 80,
    experience: 1,
    levelOfHydrated: 0,
    dizziness: true
});

solve({ weight: 120,
    experience: 20,
    levelOfHydrated: 200,
    dizziness: true });