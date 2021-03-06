# Faker.Lorem

```cs
Faker.Lorem.Word() //=> "repellendus"

// Optional arguments: num=3, supplemental=false (words from a supplementary list of Lorem-like words)
Faker.Lorem.Words() //=> ["dolores", "adipisci", "nesciunt"]
Faker.Lorem.Words(4) //=> ["culpa", "recusandae", "aut", "omnis"]
Faker.Lorem.Words(4, true) //=> ["colloco", "qui", "vergo", "deporto"]

Faker.Lorem.Multibyte() //=> 😀

// Optional arguments: char_count=255
Faker.Lorem.Characters() //=> "uw1ep04lhs0c4d931n1jmrspprf5wrj85fefue0y7y6m56b6omquh7br7dhqijwlawejpl765nb1716idmp3xnfo85v349pzy2o9rir23y2qhflwr71c1585fnynguiphkjm8p0vktwitcsm16lny7jzp9t4drwav3qmhz4yjq4k04x14gl6p148hulyqioo72tf8nwrxxcclfypz2lc58lsibgfe5w5p0xv95peafjjmm2frkhdc6duoky0aha"
Faker.Lorem.Characters(10) //=> "ang9cbhoa8"

// Optional arguments: word_count=4, supplemental=false, random_words_to_add=0
// The 'random_words_to_add' argument increases the sentence's word count by a random value within (0..random_words_to_add).
// To specify an exact word count for a sentence, set word_count to the number you want and random_words_to_add equal to 0.
// By default, sentences will not have any random words added (and will all be exactly 4 words long)
Faker.Lorem.Sentence() //=> "Quia illum libero magni."
Faker.Lorem.Sentence(3) //=> "Quaerat quam unde."
Faker.Lorem.Sentence(3, true) //=> "Vehemens velit cogo."
Faker.Lorem.Sentence(3, false, 4) //=> "Aut voluptatem illum fugit ut sit."
Faker.Lorem.Sentence(3, true, 4) //=> "Accusantium tantillus dolorem timor."

// Optional arguments: sentence_count=3, supplemental=false
Faker.Lorem.Sentences() //=> ["Vero earum commodi soluta.", "Quaerat fuga cumque et vero eveniet omnis ut.", "Cumque sit dolor ut est consequuntur."]
Faker.Lorem.Sentences(1) //=> ["Ut perspiciatis explicabo possimus doloribus enim quia."]
Faker.Lorem.Sentences(1, true) //=> ["Quis capillus curo ager veritatis voro et ipsum."]

// Optional arguments: sentence_count=3, supplemental=false, random_sentences_to_add=3
// The 'random_sentences_to_add' argument increases the paragraph's sentence count by a random value within (0..random_sentences_to_add).
// To specify an exact sentence count for a paragraph, set sentence_count to the number you want and random_sentences_to_add equal to 0.
// By default, sentences will have a random number of words within the range (3..6).
Faker.Lorem.Paragraph() //=> "Neque dicta enim quasi. Qui corrupti est quisquam. Facere animi quod aut. Qui nulla consequuntur consectetur sapiente."
Faker.Lorem.Paragraph(2) //=> "Illo qui voluptas. Id sit quaerat enim aut cupiditate voluptates dolorum. Porro necessitatibus numquam dolor quia earum."
Faker.Lorem.Paragraph(2, true) //=> "Cedo vero adipisci. Theatrum crustulum coaegresco tonsor crastinus stabilis. Aliqua crur consequatur amor una tolero sum."
Faker.Lorem.Paragraph(2, false, 4) //=> "Neque aut et nemo aut incidunt voluptates. Dolore cum est sint est. Vitae assumenda porro odio dolores fugiat. Est voluptatum quia rerum."
Faker.Lorem.Paragraph(2, true, 4) //=> "Vomito unde uxor annus. Et patior utilis sursum."

// Optional arguments: paragraph_count=3, supplemental=false
Faker.Lorem.Paragraphs() //=> ["Dolores quis quia ad quo voluptates. Maxime delectus totam numquam. Necessitatibus vel atque qui dolore.", "Id neque nemo. Dolores iusto facere est ad. Accusamus ipsa dolor ut.", "Et officiis ut hic. Sunt asperiores minus distinctio debitis ipsa dolor. Minima eos deleniti."]
Faker.Lorem.Paragraphs(1) //=> ["Labore voluptas sequi. Ratione nulla eaque quia molestiae fugit. At quam laboriosam aut ut dignissimos."]
Faker.Lorem.Paragraphs(1, true) //=> ["Depulso animi cunctatio amicitia adficio. Vester viduo qui despirmatio voluptas. Validus laudantium adopto ut agnitio venustas. Aer arcus odio esse."]
```