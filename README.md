# Criptografo
#### Projeto OpenSource para codificar e decodificar strings utilizando diferentes formas de criptografia.

Projeto desktop **.Net Framework 4.8** <br>
Biblioteca de Classes **.Net Standard 2.0.3**

---

#### Criptografias

| Nome | Particularidades | Tipo
| :--- | :--- | :---:
| DES | Criptografia com chave de 8 caractéres. Pode ser descriptografada. | Simétrico
| AES | Criptografia com chave de 16 caractéres. Pode ser descriptografada. | Simétrico
| SHA256 | Não utiliza chave. Não pode ser descriptografado. Gerá uma criptografia com 64 caractéres. | Hash Algorithm
| MD5 | Não utiliza chave. Não pode ser descriptografado. | Hash Algorithm
| RSA | Utiliza duas chaves. Pode ser descriptografado. | Assimétrico
| Zenit-Polar | Não utiliza chave. Trocar as letras da palavra Zenit pela palavra Polar | Simétrico

#### Symmetric, Asymmetric and Hash Algorithm

RSA é uma criptografia **assimétrica**, é utilizado uma chave para criptografar e uma chave diferente para descriptografar.
AES é uma criptografia **simétrica**, usa a mesma chave para criptografar e descriptografar.
SHA é um **algorítmo hash**, somente criptografa. Não há forma de descriptografar.
