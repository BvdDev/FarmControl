import Vue from "vue";
import BootstrapVue, { BCardGroup } from "bootstrap-vue";
import vSelect from "vue-select";
export class Init {
    static initializeBootstrapVue() {
        Vue.use(BootstrapVue);
        Vue.component("b-card-group", BCardGroup);
    }
    static initializeVueSelect() {
        Vue.component("v-select", vSelect);
    }
}
//# sourceMappingURL=init.js.map