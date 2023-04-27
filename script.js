const userId1 = 970;
const userId2 = 1000;

const xhttp = new XMLHttpRequest();
xhttp.onreadystatechange = function() {
  if (this.readyState == 4 && this.status == 200) {
    const users = JSON.parse(this.responseText);
    const user1 = users[0];
    const user2 = users[1];
    
    document.getElementById("user1-name").innerHTML = user1.name;
    document.getElementById("user1-image").src = user1.image;
    document.getElementById("user2-name").innerHTML = user2.name;
    document.getElementById("user2-image").src = user2.image;
  }
};
xhttp.open("GET", "http://localhost/nexaa/getUsers.php?userId1=" + userId1 + "&userId2=" + userId2, true);
xhttp.send();

document.getElementById("video-btn").addEventListener("click", function() {

});

document.getElementById("audio-btn").addEventListener("click", function() {

});

document.getElementById("call-close-btn").addEventListener("click", function() {

});

document.getElementById("sound-increase-btn").addEventListener("click", function() {
 
});

document.getElementById("sound-decrease-btn").addEventListener("click", function() {
 
});


function toggleVideo() {
  
}

function toggleAudio() {
  
}

function closeCallWindow() {
 
}

function increaseSound() {
  
}

function decreaseSound() {
  
}
