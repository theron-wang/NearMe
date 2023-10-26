function previewImage(inputElem, imgElem) {
    const url = URL.createObjectURL(inputElem.files[0]);
    imgElem.addEventListener('load', () => URL.revokeObjectURL(url), { once: true });
    imgElem.src = url;
}

function scroll(ele) {
    ele.scrollIntoView({ behavior: "smooth" });
}

function scrollbarVisible() {
    var element = document.getElementsByTagName("header")[0].parentElement;
    return element.scrollHeight > element.clientHeight;
};

async function getPosition() {
    try {
        const pos = await new Promise((resolve, reject) => {
            navigator.geolocation.getCurrentPosition(resolve, reject);
        });
        return [pos.coords.latitude, pos.coords.longitude];
    } catch {
        return null;
    }
}