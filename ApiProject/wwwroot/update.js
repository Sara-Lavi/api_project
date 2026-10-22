
const dataUser = sessionStorage.getItem("dataUser")
const user = {
    email: JSON.parse(dataUser).email,
    pass: JSON.parse(dataUser).pass,
    firstName: JSON.parse(dataUser).firstName,
    lastName: JSON.parse(dataUser).lastName,
    id: JSON.parse(dataUser).userId
}

const title = document.getElementById("title")
title.textContent += user.firstName + "!"

const show = () => {

    const show = document.getElementById("show")
    show.style.display = 'block'

    const email = document.getElementById("email")
    email.value = user.email
    const password = document.getElementById("pass")
    password.value = user.pass
    const firstName = document.getElementById("firstName")
    firstName.value = user.firstName
    const lastName = document.getElementById("lastName")
    lastName.value = user.lastName
}

const update = async () => {

    const userDetails = {
        email: document.getElementById("email").value,
        pass: document.getElementById("pass").value,
        firstName: document.getElementById("firstName").value,
        lastName: document.getElementById("lastName").value
    }

    try {
        const response = await fetch(`api/Users/${user.id}`, {
            method: 'PUT',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(userDetails)
        });

        if (response.ok) {
            title.textContent = "Hello " + userDetails.firstName + "!"
            alert("The apdate succsesfuly")
        }
        else {
            throw ("Error, try again")
        }
    }
    catch (e) {
        alert(e.message)
    }
}

