

    $(document).ready(function () {

        $("#postCustomer").on('click', function () {

            const FirstName = ['Leia', 'Sadie', 'Jose', 'Sara', 'Frank', 'Dewey', 'Tomas', 'Joel', 'Lukas', 'Carlos'];
            const LastName = ['Liberty', 'Ray', 'Harrison', 'Ronan', 'Drew', 'Powell', 'Larsen', 'Chan', 'Anderson', 'Lane']
           
            var customers = [];
        
            for (var i = 0; i < 2; i++) {
                var LN = Math.floor(Math.random() * 10);
                var FN = Math.floor(Math.random() * 10);
                customers.push({ lastName: LastName[LN], firstName: FirstName[FN], age: Math.floor(Math.random() * (90 - 10) + 10), id: Math.floor(Math.random() * 100) })
            }
            $.ajax({
                url: '/Customer/Post',
                type: 'POST',
                data: { '': customers },
                ContentType: 'application/json;utf-8',
                datatype: 'json'
            }).done(function (resp) {
                alert("Successful " + resp);
            })

        });

        $("#getCustomer").on('click', function () {
            $.ajax({
                url: '/Customer/Get',
                type: 'POST',
                ContentType: 'application/json;utf-8',
                datatype: 'json'
            }).done(function (resp) {

                var results = JSON.parse(resp);
                var trData = "";
                for (var i = 0; i < results; i++) {
                    trData += "<tr>" + "<td>" + results[i].lastName + "</td>" + "<td>" + results[i].firstName + "</td>" + "<td>" + results[i].age + "</td>"
                        + "<td>" + results[i].id + "</td>"
                }

                $("#result").append(trData)
            })

        });


    });

