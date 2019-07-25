Curl -i -H "Content-Type: application/json" -X POST -d '{"Id":2,"Name":"MyCapitalOneCard","BankName":"CapitalOne"}' http://localhost:5000/api/CreditCards

Curl -i -H "Content-Type: application/json" -X POST -d '{"Id":1,"Name":"MyChaseCard","BankName":"Chase"}' http://localhost:5000/api/CreditCards 

curl -X GET http://localhost:5000/api/CreditCards
