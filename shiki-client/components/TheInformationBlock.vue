<template>
    <div class="block">
        <div class="title">
            {{title}}
        </div>
        <slot>

        </slot>
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
        props: {
            title: {
                type: String,
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
    .block {
        margin: 0px 10px;
    }
    .title {
        font-size: 15px;
        line-height: 30px;
        padding: 0 10px;
        background: var(--headline-background-color);
        border-left: 5px solid var(--headline-border-color);
        margin-bottom: 10px;
    }
</style>