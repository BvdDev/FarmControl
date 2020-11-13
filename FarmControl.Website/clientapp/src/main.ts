import Vue from "Vue";
import { Init } from "model/init";
import router from "model/Routing";
import mainPanel from "ui/Components/MainPanel.vue";
import "expose-loader?jQuery!jquery";

import '../css/bootstrap.css';
import '../css/bootstrap-vue.css';

Init.initializeBootstrapVue();
Init.initializeVueSelect();

const v = new Vue({
    router,
    el: "#app",
    components: {
        mainPanel
    },
    template: "<div style=\"height:100%;\"><main-panel></main-panel><router-view></router-view></div>"

});

