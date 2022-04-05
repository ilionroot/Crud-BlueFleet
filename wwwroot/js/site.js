const goButtonEnter = (e, auxButton) => {
    e.target.style.left = '-1rem'
    e.target.style.top = '-1rem'

    auxButton.style.left = '1rem';
    auxButton.style.top = '1rem';
}

const goButtonLeave = (e, auxButton) => {
    e.target.style.left = '0'
    e.target.style.top = '0'

    auxButton.style.left = '0';
    auxButton.style.top = '0';
}

document.getElementsByClassName("goToMainButton")[1].addEventListener("mouseenter", (e) => {
    goButtonEnter(e, document.getElementsByClassName("goToMainButton")[0])
})
document.getElementsByClassName("goToMainButton")[1].addEventListener("mouseleave", (e) => {
    goButtonLeave(e, document.getElementsByClassName("goToMainButton")[0])
})