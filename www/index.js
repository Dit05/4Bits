const sendButton = document.getElementById('sendButton');
const userInput = document.getElementById('userInput');
const chatTextarea = document.getElementById('chatTextarea');

const username = localStorage.getItem('username');

const apiUrl = 'http://127.0.0.1:8084/messages';

async function fetchMessages() {
    try {
        const response = await fetch(apiUrl);
        const json = await response.json();
        // console.log(messages);

        chatTextarea.value = '';
        json.messages.forEach((entry) => {
            chatTextarea.value += `${entry.message.sender}: ${entry.message.content}\n`;
        });
    } catch (error) {
        console.error("Nem sikerült lekérdezni az üzeneteket!", error);
    }
}

sendButton.addEventListener('click', async function (event) {
    event.preventDefault();
    const content = userInput.value;

    if (content) {
        const messageData = {
            sender: username,
            content: content
        };

        try {
            const response = await fetch(apiUrl, {
                method: 'POST',
                headers: {
                    'Content-Type': 'application/json'
                },
                body: JSON.stringify(messageData)
            });

            if (response.ok) {
                userInput.value = '';
                fetchMessages();
            } else {
                console.error('Hiba az üzenet küldésekor:', response.statusText);
            }
        } catch (error) {
            console.error('Hiba az üzenet küldésekor:', error);
        }
    } else {
        alert('Kérem írjon be egy üzenetet!');
    }
});

setInterval(fetchMessages, 5000);
