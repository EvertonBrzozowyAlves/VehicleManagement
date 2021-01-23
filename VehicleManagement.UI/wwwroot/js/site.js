
async function fetchPost(dataToPost) {
    const response = await fetch("https://localhost:44367/Vehicles/Save", {
        method: 'POST',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(dataToPost)
    })

    if (!response.ok) {
        const message = `An error has occured: ${response.status}`
        throw new Error(message);
    }

    const jsonResponse = await response.json()
    return jsonResponse
}
