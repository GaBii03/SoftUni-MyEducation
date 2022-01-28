function solve(array){

    let heroesArr = [];
    for (let index = 0; index < array.length; index++) {
        let [name, level, items] = array[index].split(' / ');
        level = Number(level);
        items = items !== undefined ? items.split(', ') : [];

        heroesArr.push({name: name,level: level, items: items});
    }

    return JSON.stringify(heroesArr);
}

solve(['Isacc / 25 / Apple, GravityGun',
'Derek / 12 / BarrelVest, DestructionSword',
'Hes / 1 / Desolator, Sentinel, Antara']);