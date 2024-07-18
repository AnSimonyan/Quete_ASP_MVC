function deleteResource(url, id) {
    if (!confirm('Are you sure you want to delete this item?')) {
        return;
    }

    fetch(`${url}/${id}`, {
        method: 'DELETE',
        headers: {
            'Content-Type': 'application/json',
            // 'RequestVerificationToken': document.querySelector('input[name="__RequestVerificationToken"]').value
        }
    })
        .then(response => {
            if (response.ok) {
                alert('Resource deleted successfully!');
                location.reload(); // Refresh the page to reflect the deletion
            } else {
                alert('Failed to delete resource.');
            }
        })
        .catch(error => {
            console.error('Error:', error);
            alert('Failed to delete resource.');
        });
}