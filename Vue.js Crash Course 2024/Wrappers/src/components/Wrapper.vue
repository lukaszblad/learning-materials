<script setup>
    import {defineProps} from 'vue'

    defineProps({
        textColor: {
            type: String,
            default: 'blue'
        },
    })
</script>

<template>
    <div :style="`color: ${textColor};`">
        <slot></slot>
    </div>
</template>
