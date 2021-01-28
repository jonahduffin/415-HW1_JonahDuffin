

$("#submitButton").click( function () {
    assignments = parseFloat($('#assignments').val());
    groupproject = parseFloat($('#groupproject').val());
    quizzes = parseFloat($('#quizzes').val())
    exams = parseFloat($('#exams').val());
    intex = parseFloat($('#intex').val());

    finalgrade = (.5 * assignments) + (.1 * groupproject) + (.1 * quizzes) + (.2 * exams) + (.1 * intex);
    let lettergrade;
    if (finalgrade >= 94)
        lettergrade = 'A';
    else if (finalgrade >= 90)
        lettergrade = 'A-';
    else if (finalgrade >= 87)
        lettergrade = 'B+';
    else if (finalgrade >= 84)
        lettergrade = 'B';
    else if (finalgrade >= 80)
        lettergrade = 'B-';
    else if (finalgrade >= 77)
        lettergrade = 'C+';
    else if (finalgrade >= 74)
        lettergrade = 'C';
    else if (finalgrade >= 70)
        lettergrade = 'C-';
    else if (finalgrade >= 67)
        lettergrade = 'D+';
    else if (finalgrade >= 64)
        lettergrade = 'D';
    else if (finalgrade >= 60)
        lettergrade = 'D-';
    else
        lettergrade = 'E';

    $('#gradepercentage').html(String(finalgrade.toFixed(2)) + '% ' + lettergrade);
    return
}
);
