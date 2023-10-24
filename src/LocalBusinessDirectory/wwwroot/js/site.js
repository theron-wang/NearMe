function previewImage(inputElem, imgElem) {
    const url = URL.createObjectURL(inputElem.files[0]);
    imgElem.addEventListener('load', () => URL.revokeObjectURL(url), { once: true });
    imgElem.src = url;
}

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