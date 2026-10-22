
const register = async () => {

    const userData = {
        email: document.getElementById("email").value,
        pass: document.getElementById("pass").value,
        firstName: document.getElementById("firstName").value,
        lastName: document.getElementById("lastName").value
    }

    try {
        const response = await fetch('api/Users', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(userData)
        });

        if (response.ok) {
            alert("User succsesfuly addad")
        }
        else {
            throw new ("Eror, Try again")
        }
    }
    catch (e) {
        alert(e.message)
    }

}

const login = async () => {

    const userData = {
        email: document.getElementById("Email").value,
        pass: document.getElementById("Pass").value
    }

    try {
        const response = await fetch('api/Users/login', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(userData)
        });

        if (response.ok) {
            const dataUser = await response.json();
            sessionStorage.setItem("dataUser", JSON.stringify(dataUser));
            window.location.href = 'update.html'
        }
        else {
            throw new ("some error..")
        }
    }
    catch (e) {
        alert(e.massage)
    }
}

const enrollment = () => {
    const enrollment = document.getElementById("enrollment")
    enrollment.style.display = 'block'
}