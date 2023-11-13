let url = "http://localhost:5188/api/Libro/LibroAutor";
fetch(url)
  .then((response) => response.json())
  .then((data) => mostrarData(data))
  .catch((error) => console.log(error));

const mostrarData = (data) => {
  console.log(data);
  let body = "";
  for (let i = 0; i < data.length; i++) {
    body += `<tr>
                 <td>${data[i].nombreLibro}</td>
                 <td>${data[i].nombreAutor}</td>
                 <td>${data[i].chapters}</td>
                 <td>${data[i].pages}</td>
                 <td>$${data[i].price}</td>
                 </tr>`;
  }

  document.getElementById("data").innerHTML = body;
};
