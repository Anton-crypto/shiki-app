function getContenById(id: string) {
    let cards : IContent [] = [
        {
            titleContent: "Врата Штейна",
            date: "2009",
            id: "1",
            imgContentCRS: "https://moe.shikimori.one/system/animes/preview/28977.jpg?1650920449",
            typeContent: "TV Сериал",
        },
        {
            titleContent: "Гинтама",
            date: "2015",
            id: "2",
            imgContentCRS: "https://desu.shikimori.one/system/animes/preview/43608.jpg?1655486756",
            typeContent: "TV Сериал",
        },
        {
            titleContent: "Атака титанов",
            date: "2018",
            id: "3",
            imgContentCRS: "https://desu.shikimori.one/system/animes/preview/9253.jpg?1650921326",
            typeContent: "TV Сериал",
        },
    ]
    console.log(id)
    console.log(cards.filter((item) => item.id == id))
    return cards.filter((item) => item.id == id)[0];
}


export  { 
    getContenById,
} 