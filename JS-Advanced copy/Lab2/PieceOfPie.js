function solve(allFlavours, startingFl, endingFl){

    let startIndex = allFlavours.indexOf(startingFl);
    let endIndex = allFlavours.indexOf(endingFl);

    let section = allFlavours.slice(startIndex, endIndex+1);
    return section;
}