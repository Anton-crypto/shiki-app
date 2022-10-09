<template>
    <div class="headers">
        <div>
            <NuxtLink v-for="(header, index) in headers" :key="index" class="headers-item" :to="'/' + header.path">{{header.name}}</NuxtLink>
        </div>
        <div>

        </div>
    </div>
</template>
  
<script setup lang="ts">
    const headers : Array<IHeader> = [
        {
            id: "54453721-a1fs",
            name : "Главная",
            path : "",
        },
        {
            id: "54453721-asfs",
            name : "Аниме",
            path : "content-anime",
        },
        {
            id: "54323721-asfs",
            name : "Манга",
            path : "content-manga",
        },
        {
            id: "54343721-asfs",
            name : "Статьи",
            path : "content-articles",
        },
        {
            id: "54621221-asfs",
            name : "Ранобэ",
            path : "content-novel",
        },
    ]

</script>

<style lang="scss">
    .headers {
        background-color: #343434;
        padding: 15px 20px;
        
        &-item {
            padding: 10px 5px;
            color: rgb(250, 248, 244);
            text-decoration: none;
        }
    }
</style>