<template>
    <div>
        <div class="header">
            {{card.titleContent}}
        </div>
        <div class="content">
            <div>
                <div>
                    <img :src="card.imgContentCRS" alt="">
                </div>
            </div>
            <div>
                <TheInformationBlock
                    title= "ИНФОРМАЦИЯ"
                >
                    <div>
                        Тип: TV Сериал
                        Эпизоды: 7 / 13
                        Следующий эпизод: 28 нояб. 18:00
                        Длительность эпизода: 24 мин.
                    </div>
                </TheInformationBlock>
                <TheInformationBlock title= "РЕЙТИНГ">
                    <TheRating></TheRating>
                </TheInformationBlock>
                <TheInformationBlock title= "СТУДИЯ">
                    <img src="https://kawai.shikimori.one/system/studios/original/1.png?1378753179" alt=""> 
                </TheInformationBlock>
            </div>
        </div>
    </div>
</template>

<script>
    import { getContenById } from "@/use/getContentById"
    import { useRoute } from "vue-router";

    export default {
        data() {
            return {
            }
        },
        setup () {
            const route = useRoute()
            const card = getContenById(route.params.id);

            return {
                card
            }
        },
        created() {
            this.initiation();
        },
        methods: {  
            initiation() {
            },
        }
    }
</script>

<style lang="scss">
    .content {
        display: flex;
    }
</style>