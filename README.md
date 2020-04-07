# Criptografo
#### Projeto OpenSource para codificar e decodificar strings utilizando diferentes formas de criptografia.

Projeto desktop **.Net Framework 4.8** <br>
Biblioteca de Classes **.Net Standard 2.0.3**

---

<center>
<img src="https://user-images.githubusercontent.com/43295412/78674757-7d520980-78ba-11ea-8373-0ab77db25ba1.png" width="50%" />
</center>

#### Criptografias

| Nome | Particularidades | Tipo
| :--- | :--- | :---:
| DES | Criptografia com chave de 8 caractéres. Pode ser descriptografada. | Simétrico
| AES | Criptografia com chave de 16 caractéres. Pode ser descriptografada. | Simétrico
| SHA256 | Não utiliza chave. Não pode ser descriptografado. Gerá uma criptografia com 64 caractéres. | Hash Algorithm
| MD5 | Não utiliza chave. Não pode ser descriptografado. | Hash Algorithm
| RSA | Utiliza duas chaves. Pode ser descriptografado. | Assimétrico
| Zenit-Polar | Não utiliza chave. Troca as letras da palavra Zenit pela palavra Polar | Simétrico

#### Symmetric, Asymmetric and Hash Algorithm

RSA é uma criptografia **assimétrica**, é utilizado uma chave para criptografar e uma chave diferente para descriptografar.
AES é uma criptografia **simétrica**, usa a mesma chave para criptografar e descriptografar.
SHA é um **algorítmo hash**, somente criptografa. Não há forma de descriptografar.

#### Gerando Chaves

A geração de chaves na biblioteca de classes é feita utilizando o Guid. Após criar um novo Guid, dependendo se deseja uma chave DES ou AES, este é recortado parar 8 ou 16 caractéres. Já na geração das chaves RSA é criado uma pasta (caso não exista), no diretório raiz `.\crypt`. É então feito dois arquivos `public.key` e `private.key`. Sendo arquivos com corpo XML, para facilitar sua leitura (por humanos, não pela máquina :smile: ).
