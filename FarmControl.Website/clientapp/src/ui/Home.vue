<template>
    <div>ssf4sfdf</div>
</template>

<script lang="ts">
    import Axios from "axios";
    import vue from "vue";
    import { Component } from "vue-property-decorator";

    @Component
    export default class Home extends vue {
        animal: any;

        mounted() {
            Axios({
                url: 'AnimalType/GetAll',
                method: 'GET',
                responseType: 'json'
            })
                .then(response => {
                    this.animal = response.data;
                })
                .catch(error => {
                    console.log(error);
                })
        }
    }
</script>