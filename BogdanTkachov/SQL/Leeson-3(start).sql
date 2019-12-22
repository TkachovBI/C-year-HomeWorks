SELECT amount, payment_date
FROM sakila.payment
WHERE amount != 2.99
ORDER BY amount ASC;