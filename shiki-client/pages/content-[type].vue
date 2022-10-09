<template>
    <div class="contents">
        <TheCard v-for="(card, index) in cards" :card="card" class="contents-item" :key="index"></TheCard>
    </div>
</template>

<script setup lang="ts">
    const router = useRouter();

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
</script>

<style lang="scss">
    .contents {
        &-item {
            margin: 10px;
        }
        padding: 10px;
        display: flex;
        flex-wrap: wrap;
    }
</style>