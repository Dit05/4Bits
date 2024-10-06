document.querySelector('form').addEventListener('submit', function(event) {
    event.preventDefault();

    const username = document.getElementById('felhasznalonev').value;

    if (username) {
        localStorage.setItem('username', username);
        window.location.href = 'content.html';
    } else {
        alert('Kérlek, adj meg egy nevet!');
    }
});
