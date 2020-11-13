import Vue from "vue";
import BootstrapVue, { BCardGroup } from "bootstrap-vue";
import vSelect from "vue-select";

export class Init {
    static initializeBootstrapVue(): void {
        Vue.use(BootstrapVue);
        Vue.component("b-card-group", BCardGroup);
    }

    static initializeVueSelect(): void {
        Vue.component("v-select", vSelect);
    }
}