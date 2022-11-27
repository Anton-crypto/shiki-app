<template>
    <div class="card">
        <div class="card-image">
            <img :src="card.imgContentCRS" alt="">
        </div>
        <div class="card-title">
            {{ card.titleContent }}
        </div>
        <div class="card-des">
            <div class="card-type">
                {{ card.typeContent }}
            </div>
            <div class="card-date">
                {{ card.date }}
            </div>
        </div>
    </div>
</template>

<script lang="ts" setup>

    import { PropType } from 'vue'

    const props = defineProps({
        card: Object as PropType<IContent>,
    }); 

    const card = props?.card;

</script>

<style lang="scss">
    .card {
        &-des {
            display: flex;
            justify-content: space-between;
        }
        &-image {
            width: 150px;
            height: 210px;
            img {
                width: 100%;
                height: 100%;
            }
        }
    }
</style>